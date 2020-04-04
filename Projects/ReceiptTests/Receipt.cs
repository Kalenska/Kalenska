namespace ReceiptTests
{
    internal class Receipt
    {
        private int v1;
        private string v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        private int v8;
        private string v9;
        private decimal v10;
        private int v11;

        public Receipt(int v1, string v2, int v3, string v4, string v5, string v6, string v7, int v8, string v9, decimal v10, int v11)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
            this.v9 = v9;
            this.v10 = v10;
            this.v11 = v11;
        }

        public int ReceiptNumber { get; internal set; }
    }
}