using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    class Hexamaze
    {

        Node origin;
        public void SetUpMaze()
        {
            //center
            origin = new Node(0, 0);
            

            //circle 1
            

        }

        public class Node
        {
            int q;
            int r;
            int s;

            public Node(int q, int r, int s)
            {
                this.q = q;
                this.r = r;
                this.s = s;
            }

            public Node(int q, int r) : this(q, r, -q - r)
            { }
        }
    }
}
