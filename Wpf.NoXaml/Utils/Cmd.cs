using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wpf.NoXaml.Utils
{
    public delegate void Dispatch<in TMessage>(TMessage message);

    public delegate void Sub<out TMessage>(Dispatch<TMessage> dispatch);

    public class Cmd<TMessage>
    {
        public Cmd(IEnumerable<Sub<TMessage>> subs)
        {
            Subs = subs.ToList();
        }

        public IReadOnlyCollection<Sub<TMessage>> Subs { get; }
    }

    public static class Cmd
    {
        public static Cmd<TMessage> None<TMessage>()
        {
            return new Cmd<TMessage>(new Sub<TMessage>[0]);
        }

        public static Cmd<TMessage> OfSub<TMessage>(Sub<TMessage> sub)
        {
            return new Cmd<TMessage>(new[] { sub });
        }

        public static Cmd<TMessage> OfMsg<TMessage>(TMessage message)
        {
            return OfSub<TMessage>(dispatch => dispatch(message));
        }

        public static Cmd<TMessage> Batch<TMessage>(IEnumerable<Cmd<TMessage>> cmds)
        {
            return new Cmd<TMessage>(cmds.SelectMany(p => p.Subs));
        }

        public static Cmd<TMessage> Batch<TMessage>(params Cmd<TMessage>[] cmds)
        {
            return Batch(cmds.AsEnumerable());
        }

        public static Cmd<TMessage> OfAsync<TResult, TMessage>(
            Func<Task<TResult>> action,
            Func<TResult, TMessage> ofSuccess,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch)
            {
                try
                {
                    dispatch(ofSuccess(await action()));
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            }

            return OfSub<TMessage>(Sub);
        }

        public static Cmd<TMessage> OfAsync<TMessage>(
            Func<Task> action,
            TMessage success,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch)
            {
                try
                {
                    await action();
                    dispatch(success);
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            }

            return OfSub<TMessage>(Sub);
        }
    }
}
