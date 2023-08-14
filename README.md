<!-- # BiliLite

由于个人原因，该项目停止维护，有兴趣的可以自行Fork维护。

其他客户端推荐：

@Richasy云之幻大佬开发的UWP，很好看也很好用

https://github.com/Richasy/Bili.Uwp

哔哩哔哩官方客户端，现在体验也很好了，建议大家去试试

https://app.bilibili.com/

感谢大家6年多以来的支持。 -->

# BiliLite

> BiliBili 第三方 UWP 客户端

修改：

- TitleBar 拖动失效和区域拉伸问题

- 分离窗口（待改）

Fork 自：后续接手维护的 ywmoyue 大佬
https://github.com/ywmoyue/biliuwp-lite

源头：逍遥橙子大佬

https://github.com/xiaoyaocz/biliuwp-lite

## 下载

https://github.com/ywmoyue/biliuwp-lite/releases

## 安装

https://github.com/ywmoyue/biliuwp-lite/blob/master/document/install-readme.md

## 讨论

https://github.com/ywmoyue/biliuwp-lite/discussions

## 截图

![](./document/_img/readme-img-01.jpg)

![](./document/_img/readme-img-02.jpg)

## 构建

- 版本发布可能不够及时，有些问题可能 dev 分支修复了却没发版本，有一定编程基础的可以自行 Clone 项目下来自己构建

### 步骤

1. 使用 Terminal 运行

```sh
git clone -b dev https://github.com/ywmoyue/biliuwp-lite.git
```

2. 双击项目中的 BiliLite.sln 文件使用 VisualStudio2019 以上的版本打开
3. 右键点击 BiliLite.Packages 项目，选择设为启动项目
4. 按 ctrl+f5 开始构建并执行，成功后关闭 VS 即可
