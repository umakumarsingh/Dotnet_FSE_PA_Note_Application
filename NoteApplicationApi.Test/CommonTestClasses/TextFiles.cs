using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NoteApplicationApi.Test.CommonTestClasses
{
    public static class TextFiles
    {
        public static void CreatefunctionalTextfile()
        {
            if (!File.Exists("../../../../../output_revised.txt"))
            {
                try
                {
                    File.Create("../../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                File.Delete("../../../../../output_revised.txt");
                File.Create("../../../../../output_revised.txt").Dispose();
            }
        }
        public static void CreateBoundaryTextfile()
        {

            if (!File.Exists("../../../../output_boundary_revised.txt"))
            {
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }

        }
        public static void AppendTextAllFunctionalText(string methodname,bool finalresult)
        {
            File.AppendAllText("../../../../../output_functional_revised.txt", methodname +" = " + finalresult + "\n");
        }
        public static void AppendTextAllBoundaryText(string methodname, bool finalvalue)
        {
            File.AppendAllText("../../../../output_boundary_revised.txt", methodname  + " = " + finalvalue + "\n");
        }
    }
}
