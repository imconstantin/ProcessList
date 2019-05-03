using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
                if (File.Exists(path + "\\ProcessList_JSON_export.json"))
                {
                    DialogResult overWrite = MessageBox.Show("File already exists. Do you want to overwrite it?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (overWrite == DialogResult.Yes)
                    {
                        File.WriteAllText(path + "\\ProcessList_JSON_export.json", jsonObj);
                        result = true;
                    }
                }
                else
                {
                    File.WriteAllText(path + "\\ProcessList_JSON_export.json", jsonObj);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
