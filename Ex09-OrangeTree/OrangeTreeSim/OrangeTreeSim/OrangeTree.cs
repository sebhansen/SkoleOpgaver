using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetNumOranges()
        {
            return numOranges;
        }
        public int GetOrangesEaten()
        {
            return orangesEaten;
        }
        public void OneYearPasses()
        {
            age++;
            numOranges = 0;
            orangesEaten = 0;
            if (age > 0 && age < 80)
            {
                height += 2;
            }
            else
            {
                treeAlive = false;
            }
            if (age <= 80 && age > 1)
            {
                numOranges = (age-1) * 5;
            }
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten += count;
                numOranges -= count;
            }
        }
    }
}
