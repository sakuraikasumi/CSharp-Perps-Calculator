# CSharp-Perps-Calculator

一个使用 C# 和 Windows Forms 编写的合约盈亏计算器，用于根据开仓价格、平仓价格、成交数量和杠杆倍数，快速估算起始保证金、盈亏和回报率。

## 功能

- 支持做多和做空两种方向
- 支持 1x 到 100x 杠杆选择
- 可输入开仓价格、平仓价格和成交数量
- 自动计算起始保证金、盈亏和回报率
- 根据盈亏结果使用不同颜色显示收益或亏损

## 计算公式

起始保证金：

```text
开仓价格 * 成交数量 / 杠杆倍数
```

做多盈亏：

```text
(平仓价格 - 开仓价格) * 成交数量
```

做空盈亏：

```text
(开仓价格 - 平仓价格) * 成交数量
```

回报率：

```text
盈亏 / 起始保证金 * 100%
```

## 运行环境

- Windows
- .NET 8 SDK
- Visual Studio 2022 或支持 .NET 8 的 IDE

## 如何运行

1. 克隆仓库：

```bash
git clone https://github.com/sakuraikasumi/CSharp-Perps-Calculator.git
```

2. 进入项目目录：

```bash
cd CSharp-Perps-Calculator
```

3. 使用 Visual Studio 打开解决方案文件：

```text
CSharp-Perps-Calculator.slnx
```

4. 直接运行项目。

也可以使用命令行构建：

```bash
dotnet build
```

## 项目结构

```text
CSharp-Perps-Calculator/
├── CSharp-Perps-Calculator.csproj
├── CSharp-Perps-Calculator.slnx
├── Program.cs
├── Form1.cs
├── Form1.Designer.cs
└── Form1.resx
```
