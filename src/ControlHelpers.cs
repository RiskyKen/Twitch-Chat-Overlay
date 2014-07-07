using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace twitch_chat_overlay
{
    public static class ControlHelpers
    {
        /// <summary>
        /// Invokes the given action on the given control's UI thread, if invocation is needed.
        /// </summary>
        /// <param name="control">Control on whose UI thread to possibly invoke.</param>
        /// <param name="action">Action to be invoked on the given control.</param>
        public static void MaybeInvoke(this Control control, Action action)
        {
            if (control != null && control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <summary>
        /// Maybe Invoke a Func that returns a value.
        /// </summary>
        /// <typeparam name="T">Return type of func.</typeparam>
        /// <param name="control">Control on which to maybe invoke.</param>
        /// <param name="func">Function returning a value, to invoke.</param>
        /// <returns>The result of the call to func.</returns>
        public static T MaybeInvoke<T>(this Control control, Func<T> func)
        {
            if (control != null && control.InvokeRequired)
            {
                return (T)(control.Invoke(func));
            }
            else
            {
                return func();
            }
        }
    }
}
