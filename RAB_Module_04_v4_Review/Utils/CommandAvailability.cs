﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAB_Module_04_v4_Review
{
    internal class CommandAvailability : IExternalCommandAvailability
    {
        public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
        {
            bool result = true;
            //UIDocument activeDoc = applicationData.ActiveUIDocument;
            //if (activeDoc != null && activeDoc.Document != null)
            //{
            //    result = true;
            //}

            return result;
        }
    }
}
