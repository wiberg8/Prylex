using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrylanLibary
{
    public class import
    {
        public void importpeoplefromfile(string filename, string tillhorighet)
        {
            throw new NotImplementedException();
            //if (!file.exists(filename))
            //{
            //    return;
            //}
            //encoding encoding = io.getencoding(filename);
            //if (!(encoding == encoding.utf8 || encoding == encoding.ascii))
            //{
            //    messagebox.show("filen måste ha utf8 eller ascii enkodning");
            //    return;
            //}

            //clearinlastpersoner();
            //list<string> filedata = file.readalllines(filename).tolist();
            //if (filedata.count > 0)
            //{
            //    filedata.removeat(0);
            //}
            //foreach (string line in filedata)
            //{
            //    string[] linesplit = line.split(';');
            //    if (linesplit.length >= 3)
            //    {
            //        person p = new person()
            //        {
            //            fornamn = linesplit[0],
            //            efternamn = linesplit[1],
            //            persnr = linesplit[2],
            //            tillhorighet = cbtillhorighet.text
            //        };
            //        addinlastperson(p);
            //    }
            //}
        }
    }
}
