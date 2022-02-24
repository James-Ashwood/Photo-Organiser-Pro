using MetadataExtractor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Tulpep.NotificationWindow;
using System.Drawing;
using MediaDevices;

namespace Photo_Organiser_Pro
{
    public class CopySettings
    {
        public string InputSource { get; set; }
        public string OutputSource { get; set; }
        public string NamingSetup { get; set; }
        public string FolderSetup { get; set; }

        public CopySettings(string InputSourceParameter, string OuputSourceParameter, string NamingSetupParameter, string FolderSetupParameter)
        {
            this.InputSource = InputSourceParameter;
            this.OutputSource = OuputSourceParameter;
            this.NamingSetup = NamingSetupParameter;
            this.FolderSetup = FolderSetupParameter;
        }

        public List<string> AccessData()
        {
            return new List<string>(){ this.InputSource, this.OutputSource, this.NamingSetup, this.FolderSetup};
        }

        public void WriteData(string key, string value)
        {
            if (key == "InputSource")
            {
                this.InputSource = value;
            }
            else if (key == "OutputSource")
            {
                this.OutputSource = value;
            }
            else if (key == "NamingSetup")
            {
                this.NamingSetup = value;
            }
            else if (key == "FolderSetup")
            {
                this.FolderSetup = value;
            }
        }

        public void WriteToDefault(string fileLocation)
        {
            File.WriteAllText(
                fileLocation,
                JsonConvert.SerializeObject(this),
                Encoding.UTF8
            );                                                                  // Write the current setup to the file

            PopupNotifier popup = new PopupNotifier();                          // Update the user
            popup.TitleText = "Settings Saved";                                 // Set the title text to "Settings Saved"
            popup.ContentText = "Updateded settings saved successfully";        // Set the conent text to "Updateded settings saved successfully"
            popup.Popup();                                                      // Show the Popup
        }
    }
}
