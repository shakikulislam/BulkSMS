using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace BulkSMS
{
    public class Common
    {
        public void LoadModemList(ComboBox comboBoxModemList)
        {
            List<Modem> modems = new List<Modem>();
            modems.Add(new Modem() { Name = "---Select---", Value = "0" });

            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(
                "root\\CIMV2",
                "SELECT * FROM Win32_POTSModem"
            );

            foreach (var queryObj in objectSearcher.Get())
            {

                if ((string)queryObj["Status"] == "OK")
                {
                    modems.Add(new Modem() { Name = queryObj["Description"].ToString(), Value = queryObj["AttachedTo"].ToString() });
                }
            }

            comboBoxModemList.DataSource = modems;
            comboBoxModemList.DisplayMember = "Name";
            comboBoxModemList.ValueMember = "Value";

        }
    }
}
