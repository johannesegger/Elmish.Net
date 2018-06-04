using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using FluentAssertions;
using LanguageExt;
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
                    return VNode.Create<object>();
                },
                ImmediateScheduler.Instance,
                () => new RootNode().Content);

            messages.Should().BeEquivalentTo(new[] { "view", "init", "update" }, config => config.WithStrictOrdering());
        }

        private class RootNode
        {
            public object Content { get; set; }
        }
    }
}