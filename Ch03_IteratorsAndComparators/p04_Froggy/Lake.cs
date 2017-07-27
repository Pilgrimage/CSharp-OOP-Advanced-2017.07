namespace p04_Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private readonly int[] stones;

        public Lake(int[] stones)
        {
            this.stones = stones;
        }

        public int[] Stones => this.stones;

        private int StonesCount => this.stones.Length;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.StonesCount; i += 2)
            {
                yield return this.stones[i];
            }

            int lastOddIndex = ((this.StonesCount - 1) % 2 != 0)
                ? this.StonesCount - 1
                : this.StonesCount - 2;

            for (int i = lastOddIndex; i > 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}