using System;
using System.Collections.Generic;

namespace CP380_B1_BlockList.Models
{
    public class BlockList
    {
        public IList<Block> Chain { get; set; }

        public int Difficulty { get; set; } = 2;

        public BlockList()
        {
            Chain = new List<Block>();
            MakeFirstBlock();
        }

        public void MakeFirstBlock()
        {
            var block = new Block(DateTime.Now, null, new List<Payload>());
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public void AddBlock(Block block)
        {
            // TODO
            block.PreviousHash = Chain[Chain.Count - 1].Hash;
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public bool IsValid()
        {
            // TODO
            string hashValue = new String('C', Difficulty);
            int error = 0;
            for (int i = 1; i < Chain.Count; i++)
            {
                string hashedString = Chain[i].Hash;
                if (Chain[i].PreviousHash != Chain[i - 1].Hash || hashedString.Substring(0, Difficulty) != hashValue)
                {
                    error++;
                }
            }
            if (error != 0)
                return false;
            else
                return true;
        }
    }
}
