/*
Manual Whisker Annotator - A program to manually annotate whiskers and analyse them
Copyright (C) 2015 Brett Michael Hewitt

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Input;

namespace RobynsWhiskerTracker.Commands
{
    public class ActionCommand : ICommand
    {
        private Action m_ExecuteAction;
        private Func<bool> m_CanExecuteAction = () => true;

        public event EventHandler CanExecuteChanged;

        public Action ExecuteAction
        {
            get
            {
                return m_ExecuteAction;
            }
            set
            {
                m_ExecuteAction = value;
            }
        }

        public Func<bool> CanExecuteAction
        {
            get
            {
                return m_CanExecuteAction;
            }
            set
            {
                m_CanExecuteAction = value;

                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteAction();
        }

        public void Execute(object parameter)
        {
            ExecuteAction();
        }

        public void RaiseCanExecuteChangedNotification()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
