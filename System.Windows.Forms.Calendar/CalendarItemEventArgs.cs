using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace System.Windows.Forms.Calendar
{
    public class CalendarItemEventArgs
        : EventArgs
    {
        #region Ctor

        /// <summary>
        /// Creates a new <see cref="CalendarItemEventArgs"/>
        /// </summary>
        /// <param name="item">Related Item</param>
        public CalendarItemEventArgs(CalendarItem item)
        {
            _item = item;
        }

        public CalendarItemEventArgs(CalendarItem item, MouseEventArgs mouseEventArgs)
        {
            _item = item;
            _mouseEventArgs = mouseEventArgs;
        }

        #endregion

        #region Props

        private CalendarItem _item;
        private MouseEventArgs _mouseEventArgs;

        /// <summary>
        /// Gets the <see cref="CalendarItem"/> related to the event
        /// </summary>
        public CalendarItem Item
        {
            get { return _item; }
        }

        /// <summary>
        /// Gets the <see cref="CalendarItem"/> related to the event
        /// </summary>
        public MouseEventArgs MouseEventArgs
        {
            get { return _mouseEventArgs; }
        }


        #endregion
    }
}
