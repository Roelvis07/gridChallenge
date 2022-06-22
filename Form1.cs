using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //List<string> listilla = new List<string>() { "ebacd", "fghij", "olmkn", "trpqs", "xywuv" };
            List<string> listilla = new List<string>() { "abc", "hjk", "mpq", "rtv" };
            Console.WriteLine(gridChallenge(listilla));
        }
        public static string gridChallenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                grid[i] = String.Concat(grid[i].OrderBy(ch => ch));
            }

            for (int i = 0; i < grid[0].Length; i++)
            {
                for (int j = 1; j < grid.Count; j++)
                {
                    if (grid[j][i] < grid[j-1][i])
                        return "NO";
                   
                }
            }

            return "YES";
        }
    }
}
