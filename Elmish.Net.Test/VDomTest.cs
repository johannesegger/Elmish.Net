using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using Elmish.Net.VDom;
using FluentAssertions;
using Xunit;
using static LanguageExt.Prelude;
using static Elmish.Net.ElmishApp<int>;
using System.Reactive.Linq;

namespace Elmish.Net.Test
{
    public class VDomTest
    {
        [Fact]
        public void ShouldCreateInitialDom()
        {
            var dom = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Set(
                            p => p.Child1,
                            VDomNode<A>()
                                .Set(p => p.Child1, 3))
                        .Set(p => p.Child2, 2))
                .Set(p => p.Child2, 1);

            var fn = dom.MergeWith(None);
            var actual = fn(None).Node.MatchUnsafe(o => (A)o, () => null);
            var expected = new A { Child1 = new A { Child1 = new A { Child1 = 3 }, Child2 = 2 }, Child2 = 1 };
            actual.Should().Be(expected);
        }

        [Fact]
        public void ShouldCreateDomDiff()
        {
            var dom1 = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Set(
                            p => p.Child1,
                            VDomNode<A>()
                                .Set(p => p.Child1, 3))
                        .Set(p => p.Child2, 2))
                .Set(p => p.Child2, 1);

            var dom2 = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Set(
                            p => p.Child1,
                            VDomNode<B>()
                                .Set(p => p.Child1, 3))
                        .Set(p => p.Child2, 2))
                .Set(p => p.Child2, 1);

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.IfNone(v1);

            var expected = new A { Child1 = new A { Child1 = new B { Child1 = 3 }, Child2 = 2 }, Child2 = 1 };
            v2.Should().Be(expected);
        }

        [Fact]
        public void ShouldUpdateChangedPropertiesOnly()
        {
            var (o1, o2, o3) = (new C(), new C(), new C());
            var dom1 = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Set(
                            p => p.Child1,
                            VDomNode<A>()
                                .Set(p => p.Child1, o1))
                        .Set(p => p.Child2, o2))
                .Set(p => p.Child2, o3);

            var dom2 = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Set(
                            p => p.Child1,
                            VDomNode<B>()
                                .Set(p => p.Child1, new C()))
                        .Set(p => p.Child2, new C()))
                .Set(p => p.Child2, new C());

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);
            var a1 = (A)v1.Child1;
            var a2 = (A)a1.Child1;

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.Some(o => (A)o).None(v1);

            v2.Child2.Should().BeSameAs(o3);
            ((A)v2.Child1).Child2.Should().BeSameAs(o2);
            ((B)((A)v2.Child1).Child1).Child1.Should().NotBeSameAs(o1); // different parent
            v2.Child1.Should().BeSameAs(a1);
        }

        [Fact]
        public void ShouldCreateNewCollectionNodes()
        {
            var dom1 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<C>());

            var dom2 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<C>(),
                    VDomNode<C>());

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);
            var c1 = v1.Children[0];
            var c2 = v1.Children[1];

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.Some(o => (A)o).None(v1);

            v2.Children.Count.Should().Be(3);
            v2.Children[0].Should().BeSameAs(c1);
            v2.Children[1].Should().BeSameAs(c2);
        }

        [Fact]
        public void ShouldReplaceExistingCollectionNodes()
        {
            var dom1 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<B>(),
                    VDomNode<C>());

            var dom2 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<C>(),
                    VDomNode<C>());

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);
            var c1 = v1.Children[0];
            var c3 = v1.Children[2];

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.Some(o => (A)o).None(v1);

            v2.Children.Count.Should().Be(3);
            v2.Children[0].Should().BeSameAs(c1);
            v2.Children[1].Should().BeOfType<C>();
            v2.Children[2].Should().BeSameAs(c3);
        }

        [Fact]
        public void ShouldRemoveExistingCollectionNodes()
        {
            var dom1 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<C>(),
                    VDomNode<C>());

            var dom2 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<C>(),
                    VDomNode<C>());

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.Some(o => (A)o).None(v1);

            v2.Children.Count.Should().Be(2);
        }

        [Fact]
        public void ShouldUpdateExistingCollectionNodes()
        {
            var dom1 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<B>(),
                    VDomNode<B>().Set(p => p.Child1, 5),
                    VDomNode<B>());

            var dom2 = VDomNode<A>()
                .SetChildNodes(
                    p => p.Children,
                    VDomNode<B>(),
                    VDomNode<B>().Set(p => p.Child1, 6),
                    VDomNode<B>());

            var fn1 = dom1.MergeWith(None);
            var v1 = fn1(None).Node.MatchUnsafe(o => (A)o, () => null);

            var fn2 = dom2.MergeWith(Optional(dom1 as IVDomNode<int>));
            var v2 = fn2(v1).Node.Some(o => (A)o).None(v1);

            ((B)v1.Children[1]).Child1.Should().BeSameAs(((B)v2.Children[1]).Child1);
            ((B)v2.Children[1]).Child1.Should().Be(6);
        }

        [Fact]
        public void ShouldSetupDirectSubscriptions()
        {
            var subject = new Subject<int>();
            var items = new List<int>();
            var dom1 = VDomNode<A>()
                .Subscribe(a => subject.AsObservable());

            var fn1 = dom1.MergeWith(None);
            subject.OnNext(1);
            using (fn1(None).Subscriptions.Subscribe(items.Add))
            {
                subject.OnNext(2);
                subject.OnNext(3);
                subject.OnNext(4);
            }
            subject.OnNext(5);

            items.Should().BeEquivalentTo(new[] { 2, 3, 4 }, p => p.WithStrictOrdering());
        }

        [Fact]
        public void ShouldSetupChildSubscriptions()
        {
            var subject = new Subject<int>();
            var items = new List<int>();
            var dom1 = VDomNode<A>()
                .Set(
                    p => p.Child1,
                    VDomNode<A>()
                        .Subscribe(a => subject.AsObservable()));

            var fn1 = dom1.MergeWith(None);
            subject.OnNext(1);
            using (fn1(None).Subscriptions.Subscribe(items.Add))
            {
                subject.OnNext(2);
                subject.OnNext(3);
                subject.OnNext(4);
            }
            subject.OnNext(5);

            items.Should().BeEquivalentTo(new[] { 2, 3, 4 }, p => p.WithStrictOrdering());
        }

        [Equals]
        private class A
        {
            public object Child1 { get; set; }
            public object Child2 { get; set; }
            public System.Collections.IList Children { get; set; } = new List<object>();
        }

        [Equals]
        private class B
        {
            public object Child1 { get; set; }
            public object Child2 { get; set; }
        }

        [Equals]
        private class C
        {
        }
    }
}