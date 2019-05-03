using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CsvHelper;

namespace ProcessList
{
    static class ExportList
    {

        public static bool ExportToJSON(List<ProcessInfo> processes, string path)
        {
            bool result = false;
            var jsonObj = Newtonsoft.Json.JsonConvert.SerializeObject(processes, Newtonsoft.Json.Formatting.Indented);

            try
            {
                File.WriteAllText(path, jsonObj);
                result = true;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public static bool ExportToXML(List<ProcessInfo> processes, string path)
        {
            bool result = false;
            XmlSerializer xmlWriter = new XmlSerializer(typeof(List<ProcessInfo>));

            try
            {
                FileStream file = File.Create(path);
                xmlWriter.Serialize(file, processes);
                file.Close();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public static bool ExportToCSV(List<ProcessInfo> processes, string path)
        {
            bool result = false;

            try
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(processes);
                    writer.Flush();
                    writer.Close();

                    result = true;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
