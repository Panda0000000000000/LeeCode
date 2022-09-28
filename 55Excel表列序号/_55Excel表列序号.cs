/***************************************************
	日期：2022/09/07  16:53
	作者：夏
	描述：给你一个字符串 columnTitle ，表示 Excel 表格中的列名称。返回 该列名称对应的列序号 。

        这道题要求将 \text{Excel}Excel 表中的列名称转换成相对应的列序号。
        由于 \text{Excel}Excel 表的列名称由大写字母组成，大写字母共有 26 个，因此列名称的表示实质是 26 进制，需要将 26 进制转换成十进制。

****************************************************/

namespace _55Excel表列序号
{
    internal class _55Excel表列序号
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        //抄来的解法 先不去理解他
        public int TitleToNumber(string columnTitle)
        {
            int n = columnTitle.Length;
            int ans = 0;
            char[] chars=columnTitle.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                ans = ans * 26 + (chars[i] - 'A' + 1);
            }
            return ans;
        }
    }
}