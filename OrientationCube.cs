using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class OrientationCube : Module
    {
        private Cube goal;
        private string eyePos;
        private List<string> directions;
        public OrientationCube(Bomb bomb, StreamWriter logFileWriter, string eyePos) : base(bomb, logFileWriter, "Orientation Cube")
        {
            goal = new Cube();

            directions = new List<string>();

            this.eyePos = eyePos;
        }

        public void Solve()
        {
            Cube cube = new Cube();
        
        }

        private void FindGoal()
        {
            if (Bomb.SerialNumber.Contains("R"))
            {
                goal.top = "left";

                goal.front = null;
                goal.left = null;
                goal.right = null;
                goal.bottom = null;
                goal.back = null;

            }

            else if (Bomb.Trn.Lit || Bomb.Car.Visible)
            {
                goal.right = "bottom";

                goal.front = null;
                goal.left = null;
                goal.top = null;
                goal.back = null;
                goal.bottom = null;

            }

            else if (Bomb.SerialNumber.Contains("8") || Bomb.SerialNumber.Contains("7"))
            {
                goal.bottom = "right";
                goal.front = "back";

                goal.left = null;
                goal.top = null;
                goal.back = null;
                goal.right = null;
            }

            else if (Bomb.Battery > 2 || eyePos == "left")
            {
                goal.bottom = "top";

                goal.front = null;
                goal.left = null;
                goal.top = null;
                goal.back = null;
                goal.right = null;
            }

            else
            {
                goal.left = "top";

                goal.front = null;
                goal.bottom = null;
                goal.top = null;
                goal.back = null;
                goal.right = null;
            }
        }

        private bool CorrectAnswer(Cube cube)
        {

            if (goal.top != null)
            {
                if (goal.top != cube.top)
                {
                    return false;
                }
            }

            if (goal.back != null)
            {
                if (goal.back != cube.back)
                {
                    return false;
                }
            }

            if (goal.bottom != null)
            {
                if (goal.bottom != cube.bottom)
                {
                    return false;
                }
            }

            if (goal.front != null)
            {
                if (goal.front != cube.front)
                {
                    return false;
                }
            }

            if (goal.left != null)
            {
                if (goal.left != cube.left)
                {
                    return false;
                }
            }

            if (goal.right != null)
            {
                if (goal.right != cube.right)
                {
                    return false;
                }
            }

            return true;
        }

        private int GoalCount()
        {
            int num = 0;

            if (goal.front != null)
            {
                num++;
            }

            if (goal.left != null)
            {
                num++;
            }

            if (goal.back != null)
            {
                num++;
            }

            if (goal.top != null)
            {
                num++;
            }

            if (goal.bottom != null)
            {
                num++;
            }

            if (goal.right != null)
            {
                num++;
            }

            return num;
        }

        private class Cube
        {
            public string front, left, right, bottom, back, top;

            public Cube()
            {
                front = "front";
                left = "left";
                right = "right";
                bottom = "bottom";
                back = "back";
                top = "top";
            }

            public void RotateCubeClockwiseTop()
            {
                string oldFront = front;
                string oldLeft = left;
                string oldBack = back;
                string oldRight = right;

                front = oldRight;
                left = oldFront;
                back = oldLeft;
                right = oldBack;
            }

            public void RotateCubeCounterClockwiseTop()
            {
                RotateCubeClockwiseTop();
                RotateCubeClockwiseTop();
                RotateCubeClockwiseTop();
            }

            public void RotateCubeClockwiseFront()
            {
                string oldTop = top;
                string oldLeft = left;
                string oldBottom = bottom;
                string oldRight = right;

                top = oldLeft;
                left = oldBottom;
                bottom = oldRight;
                right = oldTop;
            }


            public void RotateCubeCounterClockwiseFront()
            {
                RotateCubeClockwiseFront();
                RotateCubeClockwiseFront();
                RotateCubeClockwiseFront();
            }

            public void Clockwsie(string eyePos)
            {
                switch(eyePos)
                {
                    case "front":
                        RotateCubeClockwiseFront();
                        break;

                    case "left":
                        RotateCubeClockwiseFront();
                        RotateCubeClockwiseTop();
                        RotateCubeCounterClockwiseFront();
                        break;

                    case "right":
                        for (int i = 0; i < 3; i++)
                        { 
                            Clockwsie("left");
                        }

                        break;

                    case "back":
                        RotateCubeCounterClockwiseFront();
                        break;
                }
                

            }
        }
    }
}
