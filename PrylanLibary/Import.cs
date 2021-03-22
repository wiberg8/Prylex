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
    //public class Import
    //{
    //    public void ImportPeopleFromFile(string fileName, string tillhorighet)
    //    {
    //        if (!File.Exists(fileName))
    //        {
    //            return;
    //        }
    //        Encoding encoding = IO.GetEncoding(fileName);
    //        if (!(encoding == Encoding.UTF8 || encoding == Encoding.ASCII))
    //        {
    //            MessageBox.Show("Filen måste ha UTF8 eller ASCII enkodning");
    //            return;
    //        }

    //        ClearInlastPersoner();
    //        List<string> fileData = File.ReadAllLines(fileName).ToList();
    //        if (fileData.Count > 0)
    //        {
    //            fileData.RemoveAt(0);
    //        }
    //        foreach (string line in fileData)
    //        {
    //            string[] lineSplit = line.Split(';');
    //            if (lineSplit.Length >= 3)
    //            {
    //                Person p = new Person()
    //                {
    //                    Fornamn = lineSplit[0],
    //                    Efternamn = lineSplit[1],
    //                    PersNr = lineSplit[2],
    //                    Tillhorighet = cbTillhorighet.Text
    //                };
    //                AddInlastPerson(p);
    //            }
    //        }
    //    }
    //}
}
