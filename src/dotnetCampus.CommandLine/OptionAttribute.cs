﻿using System;

namespace dotnetCampus.Cli
{
    /// <summary>
    /// 标记一个属性对应命令行中的一个参数。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class OptionAttribute : CommandLineAttribute
    {
        /// <summary>
        /// 获取命令行短名称。
        /// </summary>
        public char? ShortName { get; }

        /// <summary>
        /// 获取命令行长名称。
        /// </summary>
        public string LongName { get; }

        /// <summary>
        /// 将此属性与命令行参数的一个长名称进行绑定。
        /// </summary>
        /// <param name="longName">命令行长名称，使用 PascalCase 风格，区分大小写。</param>
        public OptionAttribute(string longName)
        {
            ShortName = null;
            LongName = longName;
        }

        /// <summary>
        /// 将此属性与命令行参数的一个短名称与长名称进行绑定。
        /// </summary>
        /// <param name="shortName">命令行短名称，区分大小写。</param>
        /// <param name="longName">命令行长名称，使用 PascalCase 风格，区分大小写。</param>
        public OptionAttribute(char shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;
        }
    }
}