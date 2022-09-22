using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HshlomResturant
{
    public class Employee
    {
        
        


        public string Name { get; set; }
        public string ID { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        
        public static List<TableC> tableslist = new List<TableC>();
        //Table t1 = new Table();
        

        public void OpenT(int tablenum)
        {
            TableC t = new TableC(tablenum);
            tableslist.Add(t);
        }
        public void CloseT(int tablenum)
        {
            foreach (TableC c in tableslist)
            {
                if (c.tablenum_property == tablenum)
                {
                    tableslist.Remove(c);
                    return;
                }
            }
        }

        public virtual void Open_Table_Window(int tablenum)  //open the table window
        {
            Table t1 = new Table();
            t1.tablenum_proprety = tablenum;
            t1.Show();                                      
        }
        

        
    }
}
