using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elmish.Net
{
    public delegate void Dispatch<in TMessage>(TMessage message);

    public class Cmd<TMessage>
    {
        private readonly Action<Dispatch<TMessage>> execute;

        public Cmd(Action<Dispatch<TMessage>> execute)
        {
            this.execute = execute;
        }

        public void Execute(Dispatch<TMessage> dispatch) => this.execute(dispatch);
    }

    public static class Cmd
    {
        public static Cmd<TMessage> None<TMessage>()
        {
            return new Cmd<TMessage>(_ => {});
        }

        public static Cmd<TMessage> Batch<TMessage>(IEnumerable<Cmd<TMessage>> cmds)
        {
            return new Cmd<TMessage>(dispatch => cmds.ForEach(p => p.Execute(dispatch)));
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
            return new Cmd<TMessage>(async dispatch =>
            {
                try
                {
                    dispatch(ofSuccess(await action()));
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            });
        }

        public static Cmd<TMessage> OfAsync<TMessage>(
            Func<Task> action,
            TMessage success,
            Func<Exception, TMessage> ofError)
        {
            return OfAsync(
                async () =>
                {
                    await action();
                    return (object)null;
                },
                _ => success,
                ofError
            );
        }
    }
}
