﻿/*
E1.
循环输出当前时间, 每秒输出一次
    暂停若干毫秒:
    首先引入命名空间
    using System.Threading;
    形参ms是需要暂停的毫秒数
    Thread.Sleep(int ms);

E2.
循环输入一些数字, 以0结束
输出这些数字的和



提示:
建一个类, 每个题目需要执行的代码作为这个类的一个public static void成员方法
    比如
    class T
    {
        public static void T1()
        {}
        public static void T2()
        {}
        public static void T3()
        {}
    }

1. 使用循环输出1到30内的所有的整数 (while)

2. 使用循环输出所有英文字母的大小写 (while)
    char.ToUpper(char c)
    char.ToLower(char c)

3. 求从1到1000的和并输出 (while)

4. 输入一个数字n, 求从2开始的n个偶数和 (while)
比如输入数字3, 输出12 (2+4+6); 输入数字5, 输出30 (2+4+6+8+10)

5. 循环输入一些数字, 以0结束输入 (while if)
输出这些数字的和、平均数、最大数、最小数、奇数的个数、偶数的个数
int.MaxValue int型最大值
int.MinValue int型最小值


6. 循环接收3行输入: (while if switch)
第一行: 数字1
第二行: 运算符 (+ - * / %)
第三行: 数字2
每次输出数字1和数字2按照运算符运算的结果
(如果0作为除数则输出错误, 如果输入的两个数都是0则退出循环)
    bool int.TryParse(string str,out int num)

7. 求水仙花数的个数 (while if)
水仙花数: 一个3位数, 它的每个位上的数字的 3次幂之和等于它本身
例如：1^3 + 5^3+ 3^3 = 153


8. 求从1到1000里所有能整除3的数的和 减去 所有能整除5或能整除6的数的和 (while if)

9. 循环接收输入年份, 判断这个年份是不是闰年 (while if)
能被4整除但不能被100整除的年份为普通闰年
能被400整除的为世纪闰年

10. 求从公元1年到公元1000年里, 共有多少闰年并输出 (while if)

11. 输入一个数字, 判断这个数是不是素数 (while if)
质数（prime number）又称素数
质数定义为在大于1的自然数中, 除了1和它本身以外不再有其他因数
比如3=1*3, 因数只有有1和3, 所以3是质数
4=1*4=2*2, 因数有1、2和4, 所以4不是质数
规定1不是素数

12. 输入一个数字, 如果这个数字不是素数, 输出这个数字所有的因数 (while if)

 */
