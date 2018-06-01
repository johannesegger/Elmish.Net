using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Elmish.Net
{
    public delegate void Dispatch<in TMessage>(TMessage message);

    public delegate void Sub<out TMessage>(Dispatch<TMessage> dispatch, CancellationToken ct);

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
            return OfSub<TMessage>((dispatch, _) => dispatch(message));
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
            Func<CancellationToken, Task<TResult>> action,
            Func<TResult, TMessage> ofSuccess,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch, CancellationToken ct)
            {
                try
                {
                    dispatch(ofSuccess(await action(ct)));
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            }

            return OfSub<TMessage>(Sub);
        }

        public static Cmd<TMessage> OfAsync<TMessage>(
            Func<CancellationToken, Task> action,
            TMessage success,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch, CancellationToken ct)
            {
                try
                {
                    await action(ct);
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
