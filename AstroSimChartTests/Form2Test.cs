using Microsoft.VisualStudio.TestTools.UnitTesting;
using AstroSimCharts;
using System;

namespace AstroSimChartTests
{
    [TestClass]
    public class Form2Test
    {
        [TestMethod]
        public void validateTextboxFormats_withValidFormats_returnsTrue()
        {
            ObjectDialogBox form = new ObjectDialogBox(ObjectDialogBox.State.PLANET);
            form.nameTextBox.Text = "caca";



/*            string name = "caca";
            string mass = "123.66";
            string x = "33.2";
            string y = "11.1";
            string z = "2";*/

            

        }
    }
}
