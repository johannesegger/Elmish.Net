using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Elmish.Net.VDom;
using FluentAssertions;
using Xunit;

namespace Elmish.Net.Test
{
    public class ElmishAppTest
    {
        [Fact]
        public void ShouldDispatchInitialMessages()
        {
            var messages = new List<string>();
            ElmishApp.Run(
                Observable.Return(Unit.Default),
                (State: true, Cmd: Cmd.OfMsg("init")),
                (msg, state) =>
                {
                    messages.Add(msg);
                    return (false, msg == "view" ? Cmd.OfMsg("update") : Cmd.None<string>());
                },
                (state, dispatch) =>
                {
                    if (state)
                    {
                        dispatch("view");
                    }
                    return VDomNode.Create<object>();
                },
                ImmediateScheduler.Instance,
                ImmediateScheduler.Instance,
                () => new RootNode().Content);

            messages.Should().BeEquivalentTo(new[] { "view", "init", "update" }, config => config.WithStrictOrdering());
        }

        [Fact]
        public async Task ShouldDispatchSubscriptionMessages()
        {
            var messages = new List<string>();
            ElmishApp.Run(
                Observable.Return(Unit.Default),
                (State: 0, Cmd: Cmd.OfMsg("initial")),
                (msg, state) =>
                {
                    messages.Add(msg);   
                    var cmd = Cmd.OfSub<string>(async dispatch =>
                    {
                        await Task.Delay(500);
                        dispatch($"sub {state}");
                    });
                    return (state + 1, cmd);
                },
                (state, dispatch) => VDomNode.Create<object>(),
                ImmediateScheduler.Instance,
                ImmediateScheduler.Instance,
                () => new RootNode().Content);

            await Task.Delay(1750);

            messages.Should().BeEquivalentTo(new[] { "initial", "sub 0", "sub 1", "sub 2" }, config => config.WithStrictOrdering());
        }

        private class RootNode
        {
            public object Content { get; set; }
        }
    }
}