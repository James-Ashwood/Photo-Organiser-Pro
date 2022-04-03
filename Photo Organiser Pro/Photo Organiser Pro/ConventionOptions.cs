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
    class ConventionOptions
    {
        public string StringConvention { get; set; }

        public List<string> ContainingOptions = new List<string>();

        public List<string> ConventionShorthands = new List<string>{ "DCYYYY", "DMYYYY", "DCMMM", "DMMMM", "TAMPM", "THHHH", "DCDD", "DCMM", "DCYY", "DMDD", "DMMM", "DMYY", "YYYY", "CMD", "DCD", "DCM", "DMD", "DMM", "MMM", "OP", "ON", "CM", "TSS", "TMM", "THH", "DD", "MM", "YY", "D", "M" };

        public ConventionOptions(string StringConventionInput)
        {
            this.StringConvention = StringConventionInput;
            string tempString = StringConventionInput;
            foreach (string value in this.ConventionShorthands)
            {
                if (tempString.Contains(value))
                {
                    this.ContainingOptions.Add(value.ToString());
                    tempString = tempString.Replace(value, "");
                }
            }
        }
        public string GetNewFileName(string filePath)
        {
            string returnString = StringConvention;
            foreach (string shorthand in ContainingOptions)
            {
                returnString = returnString.Replace(shorthand.ToString(), GetData(filePath, shorthand).ToString());
            }
            return returnString;
        }

        public string GetData(string filePath, string shorthand)
        {
            string replaceValue = "";
            Debug.WriteLine(filePath);
            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(filePath);
            string pureData;
            if (shorthand == "YYYY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string year = date.Split(':')[0];
                            replaceValue = year;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = tag.Description.Split(' ')[tag.Description.Split(' ').Length - 1];
                            }
                        }
                    }
                }
            }
            if (shorthand == "YY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string year = date.Split(':')[0];
                            string yearFirstTwo = year.Substring(year.Length - 2);
                            replaceValue = yearFirstTwo;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = tag.Description.Split(' ')[tag.Description.Split(' ').Length - 1];
                                replaceValue = replaceValue.Substring(replaceValue.Length - 2);
                            }
                        }
                    }
                }
            }
            if (shorthand == "MMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string month = date.Split(':')[1];
                            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                            string returnData = months[short.Parse(month)].ToString();
                            replaceValue = returnData;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = tag.Description.Split(' ')[1];
                            }
                        }
                    }
                }
            }
            if (shorthand == "MM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string month = date.Split(':')[1];
                            replaceValue = month;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = (months.IndexOf(tag.Description.Split(' ')[1])+1).ToString();
                                if (replaceValue.Length == 1)
                                {
                                    replaceValue = "0" + replaceValue;
                                }
                            }
                        }
                    }
                }
            }
            if (shorthand == "M")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string month = date.Split(':')[1];
                            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                            replaceValue = (months.FindIndex(a => a.Contains(month)) + 1).ToString();
                        }
                    }
                }
                if (replaceValue == "")
                {
                    List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = (months.IndexOf(tag.Description.Split(' ')[1]) + 1).ToString();
                            }
                        }
                    }
                }
            }
            if (shorthand == "DD")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string day = date.Split(':')[2];
                            if (day.Length == 1)
                            {
                                day = "0" + day;
                            }
                            replaceValue = day;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = tag.Description.Split(' ')[2];
                                
                            }
                        }
                    }
                }
            }
            if (shorthand == "D")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[0];
                            string day = date.Split(':')[2].TrimStart('0');
                            replaceValue = day;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                replaceValue = tag.Description.Split(' ')[2];
                                if (replaceValue.Length == 1)
                                {
                                    replaceValue = "0" + replaceValue;
                                }
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMYYYY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string year = date.Split(':')[0];
                                replaceValue = year;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMYY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string year = date.Split(':')[0];
                                string yearFirstTwo = year.Substring(year.Length - 2);
                                replaceValue = yearFirstTwo;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMMMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                replaceValue = month;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                                string returnData = (months.FindIndex(a => a.Contains(month)) + 1).ToString();
                                if (returnData.Length == 1)
                                {
                                    returnData = "0" + returnData;
                                }
                                replaceValue = returnData;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                                replaceValue = (months.FindIndex(a => a.Contains(month)) + 1).ToString();
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMDD")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string day = date.Split(':')[1];
                                if (day.Length == 1)
                                {
                                    day = "0" + day;
                                }
                                replaceValue = day;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DMD")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "File Modified Date")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string day = date.Split(':')[2].TrimStart('0');
                                replaceValue = day;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCYYYY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string year = date.Split(':')[0];
                                replaceValue = year;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCYY")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string year = date.Split(':')[0];
                                string yearFirstTwo = year.Substring(year.Length - 2);
                                replaceValue = yearFirstTwo;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCMMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                replaceValue = month;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                                string returnData = (months.FindIndex(a => a.Contains(month)) + 1).ToString();
                                if (returnData.Length == 1)
                                {
                                    returnData = "0" + returnData;
                                }
                                replaceValue = returnData;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string month = date.Split(':')[1];
                                List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                                replaceValue = (months.FindIndex(a => a.Contains(month)) + 1).ToString();
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCDD")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string day = date.Split(':')[2];
                                if (day.Length == 1)
                                {
                                    day = "0" + day;
                                }
                                replaceValue = day;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "DCD")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Digitized")
                        {
                            try
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[0];
                                string day = date.Split(':')[2].TrimStart('0');
                                replaceValue = day;
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                replaceValue = "NoAvailableData";
                            }
                        }
                    }
                }
            }
            if (shorthand == "THHHH")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[1];
                            string hour = date.Split(':')[0];
                            if (Int64.Parse(hour) > 11)
                            {
                                hour = ((Int64.Parse(hour) - 12).ToString() + "PM");
                            }
                            else
                            {
                                hour += "AM";
                            }
                            replaceValue = hour;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                pureData = tag.Description.Split(' ')[3]; 
                                string hour = pureData.Split(':')[0];
                                if (Int64.Parse(hour) > 11)
                                {
                                    hour = ((Int64.Parse(hour) - 12).ToString() + "PM");
                                }
                                else
                                {
                                    hour += "AM";
                                }
                                replaceValue = hour;
                            }
                        }
                    }
                }
            }
            if (shorthand == "THH")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[1];
                            string hour = date.Split(':')[0];
                            replaceValue = hour;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            
                            if (tag.Name == "File Modified Date")
                            {
                                pureData = tag.Description.Split(' ')[3];
                                string hour = pureData.Split(':')[0];
                                replaceValue = hour;
                            }
                        }
                    }
                }
            }
            if (shorthand == "TMM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[1];
                            string mins = date.Split(':')[1];
                            replaceValue = mins;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                pureData = tag.Description.Split(' ')[3];
                                string mins = pureData.Split(':')[1];
                                replaceValue = mins;
                            }
                        }
                    }
                }
            }
            if (shorthand == "TSS")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[1];
                            string secs = date.Split(':')[2];
                            replaceValue = secs;
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                pureData = tag.Description.Split(' ')[3];
                                string secs = pureData.Split(':')[2];
                                replaceValue = secs;
                            }
                        }
                    }
                }
            }
            if (shorthand == "TAMPM")
            {
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Date/Time Original")
                        {
                            pureData = tag.Description;
                            string date = pureData.Split(' ')[1];
                            string hour = date.Split(':')[0];
                            if (Int64.Parse(hour) > 11)
                            {
                                replaceValue = "PM";
                            }
                            else
                            {
                                replaceValue = "AM";
                            }
                        }
                    }
                }
                if (replaceValue == "")
                {
                    foreach (var directory in directories)
                    {
                        foreach (var tag in directory.Tags)
                        {
                            if (tag.Name == "File Modified Date")
                            {
                                pureData = tag.Description;
                                string date = pureData.Split(' ')[1];
                                string hour = date.Split(':')[0];
                                if (Int64.Parse(hour) > 11)
                                {
                                    replaceValue = "PM";
                                }
                                else
                                {
                                    replaceValue = "AM";
                                }
                            }
                        }
                    }
                }
            }
            if (shorthand == "CM")
            {
                string make = "", model = "";
                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Make")
                        {
                            make = tag.Description;
                            make.Replace(" ", "-");
                        }
                        if (tag.Name == "Model")
                        {
                            model = tag.Description;
                            model.Replace(" ", "-");
                        }
                    }
                }
                replaceValue = $@"{make}_{model}";
            }
            if (shorthand == "ON")
            {
                replaceValue = filePath.Split('\\')[filePath.Split('\\').Length - 1].Split('.')[0];
            }
            if (shorthand == "OP")
            {
                string fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
                replaceValue = filePath.Replace(fileName, "");
            }
            if (replaceValue == "" || replaceValue == " ")
            {
                replaceValue = "NoAvailableData";
            }
            return replaceValue;
        }
    }
}
