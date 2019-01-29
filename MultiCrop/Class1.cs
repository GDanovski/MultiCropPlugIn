using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellToolDK;
using System.Windows.Forms;
using System.IO;

namespace MultiCrop
{
    public class Main
    {
        //private Transmiter t;
        private TifFileInfo fi;
        /*
        private void ApplyChanges()
        {
            //Apply changes and reload image
            t.ReloadImage();
        }
        */
        public void Input(TifFileInfo fi, Transmiter t)
        {
            //this.t = t;
            this.fi = fi;
            Start();

            //ApplyChanges();
        }
        private void Start()
        {
            if (fi == null) return;
            if (!fi.available) return;
            if (fi.roiList[fi.cValue].Count == 0) return;
            //Main entrance
            MainFormCroper formN = new MainFormCroper(fi);

            string source = Application.StartupPath + "\\PlugIns\\MultiCropDir.txt";
            if (File.Exists(source))
            {
                formN.DirTB.Text = File.ReadAllText(source);
            }
            else
            {
                formN.DirTB.Text = fi.Dir.Substring(0, fi.Dir.LastIndexOf("\\"));
            }

            formN.Show();
        }
    }

}
