namespace Board
{
    class Position
    {
        public uint Row { get; set; }
        public uint Column { get; set; }

        public Position(uint row, uint column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return Row
                + ", "
                + Column;
        }
    }
}
