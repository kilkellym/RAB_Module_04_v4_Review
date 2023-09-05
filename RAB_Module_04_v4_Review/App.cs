#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Windows.Markup;

#endregion

namespace RAB_Module_04_v4_Review
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // 1. Create ribbon tab
            string tabName = "Revit Add-in Bootcamp";
            try
            {
                app.CreateRibbonTab(tabName);
            }
            catch (Exception)
            {
                Debug.Print("Tab already exists.");
            }

            // 2. Create ribbon panel 
            RibbonPanel panel = Utils.CreateRibbonPanel(app, tabName, "Revit Tools");

            // 3. Create button data instances
            PushButtonData btnData1 = Command1.GetButtonData();
            PushButtonData btnData2 = Command2.GetButtonData();
            PushButtonData btnData3 = Command3.GetButtonData();

            ButtonDataClass myButtonData4 = new ButtonDataClass("btn4", "Tool 4", "RAB_Module_04_v4_Review.Command1", Properties.Resources.Red_32, Properties.Resources.Red_16, "This is tool 4");
            ButtonDataClass myButtonData5 = new ButtonDataClass("btn5", "Tool 5", "RAB_Module_04_v4_Review.Command2", Properties.Resources.Yellow_32, Properties.Resources.Yellow_16, "This is tool 5");
            ButtonDataClass myButtonData6 = new ButtonDataClass("btn6", "Tool 6", "RAB_Module_04_v4_Review.Command3", Properties.Resources.Red_32, Properties.Resources.Red_16, "This is tool 6");
            ButtonDataClass myButtonData7 = new ButtonDataClass("btn7", "Tool 7", "RAB_Module_04_v4_Review.Command1", Properties.Resources.Blue_32, Properties.Resources.Blue_16, "This is tool 7");
            ButtonDataClass myButtonData8 = new ButtonDataClass("btn8", "Tool 8", "RAB_Module_04_v4_Review.Command2", Properties.Resources.Red_32, Properties.Resources.Red_16, "This is tool 8");
            ButtonDataClass myButtonData9 = new ButtonDataClass("btn9", "Tool 9", "RAB_Module_04_v4_Review.Command3", Properties.Resources.Yellow_32, Properties.Resources.Yellow_16, "This is tool 9");
            ButtonDataClass myButtonData10 = new ButtonDataClass("btn10", "Tool 10", "RAB_Module_04_v4_Review.Command1", Properties.Resources.Blue_32, Properties.Resources.Blue_16, "This is tool 10");

            SplitButtonData mySplitButtonData = new SplitButtonData("split1", "Split Button");
            PulldownButtonData myPulldownButtonData = new PulldownButtonData("pulldown1", "More Tools");

            myPulldownButtonData.LargeImage = ButtonDataClass.BitmapToImageSource(Properties.Resources.Blue_32);
            myPulldownButtonData.Image = ButtonDataClass.BitmapToImageSource(Properties.Resources.Blue_16);

            // 4. Create buttons
            PushButton myButton1 = panel.AddItem(btnData1) as PushButton;
            PushButton myButton2 = panel.AddItem(btnData2) as PushButton;

            panel.AddSlideOut();

            panel.AddStackedItems(btnData3, myButtonData4.Data, myButtonData5.Data);

            SplitButton mySplit = panel.AddItem(mySplitButtonData) as SplitButton;
            mySplit.AddPushButton(myButtonData6.Data);
            mySplit.AddPushButton(myButtonData7.Data);

            PulldownButton myPullDown = panel.AddItem(myPulldownButtonData) as PulldownButton;
            myPullDown.AddPushButton(myButtonData8.Data);
            myPullDown.AddPushButton(myButtonData9.Data);
            myPullDown.AddSeparator();
            myPullDown.AddPushButton(myButtonData10.Data);

            

            // NOTE:
            // To create a new tool, copy lines 35 and 39 and rename the variables to "btnData3" and "myButton3". 
            // Change the name of the tool in the arguments of line 

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


    }
}
