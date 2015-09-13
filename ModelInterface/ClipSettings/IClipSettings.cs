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
using RobynsWhiskerTracker.ModelInterface.MouseFrame;
using RobynsWhiskerTracker.ModelInterface.Whisker;

namespace RobynsWhiskerTracker.ModelInterface.ClipSettings
{
    public interface IClipSettings : IModelObjectBase
    {
        string ClipFilePath
        {
            get;
            set;
        }

        int StartFrame
        {
            get;
            set;
        }

        int EndFrame
        {
            get;
            set;
        }

        int FrameInterval
        {
            get;
            set;
        }

        int NumberOfWhiskers
        {
            get;
            set;
        }

        int NumberOfPointsPerWhisker
        {
            get;
            set;
        }

        bool IncludeNosePoint
        {
            get;
            set;
        }

        bool IncludeOrientationPoint
        {
            get;
            set;
        }

        int NumberOfGenericPoints
        {
            get;
            set;
        }

        int TotalNumberOfPoints
        {
            get;
        }

        IWhiskerClipSettings[] Whiskers
        {
            get;
            set;
        }

        IWhisker[] CreateEmptyWhiskers(IMouseFrame mouseFrame);
    }
}
