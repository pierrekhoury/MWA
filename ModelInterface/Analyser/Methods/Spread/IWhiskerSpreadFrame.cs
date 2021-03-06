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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobynsWhiskerTracker.ModelInterface.Analyser.Methods.Angles.WhiskerAngle;
using RobynsWhiskerTracker.ModelInterface.MouseFrame;

namespace RobynsWhiskerTracker.ModelInterface.Analyser.Methods.Spread
{
    public interface IWhiskerSpreadFrame : IAnalyserFrame<ISingleWhiskerAngle>
    {
        ISingleWhiskerAngle[] LeftWhiskers
        {
            get;
        }

        ISingleWhiskerAngle[] RightWhiskers
        {
            get;
        }

        double LeftAverage
        {
            get;
        }

        double LeftMax
        {
            get;
        }

        double RightAverage
        {
            get;
        }

        double RightMax
        {
            get;
        }

        void LoadData(IMouseFrame frame);
        void UpdateTValue(double tValue);
    }
}
