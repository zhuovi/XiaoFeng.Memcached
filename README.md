# XiaoFeng.Memcached

![fayelf](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![GitHub top language](https://img.shields.io/github/languages/top/zhuovi/XiaoFeng.Memcached?logo=github)
![GitHub License](https://img.shields.io/github/license/zhuovi/XiaoFeng.Memcached?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/XiaoFeng.Memcached?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/XiaoFeng.Memcached?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/XiaoFeng.Memcached?label=dev%20nuget&logo=nuget)

Nuget：XiaoFeng.Memcached

QQ群号：748408911 

QQ群二维码： 

![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png)

公众号： 

![畅聊了个科技](https://user-images.githubusercontent.com/16105174/198059698-adbf29c3-60c2-4c76-b894-21793b40cf34.jpg)

源码： https://github.com/zhuovi/xiaofeng.Memcached

教程： https://www.yuque.com/fayelf/xiaofeng

Memcached中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Hash,Key,String,ZSet,Stream,Log,订阅发布,线程池功能。

## XiaoFeng.Memcached

XiaoFeng.Memcached generator with [XiaoFeng.Memcached](https://github.com/zhuovi/XiaoFeng.Memcached).

## Install

.NET CLI

```
$ dotnet add package XiaoFeng.Memcached --version 1.0.0
```

Package Manager

```
PM> Install-Package XiaoFeng.Memcached --Version 1.0.0
```

PackageReference

```
<PackageReference Include="XiaoFeng.Memcached" Version="1.0.0" />
```

Paket CLI

```
> paket add XiaoFeng.Memcached --version 1.0.0
```

Script & Interactive

```
> #r "nuget: XiaoFeng.Memcached, 1.0.0"
```

Cake

```
// Install XiaoFeng.Memcached as a Cake Addin
#addin nuget:?package=XiaoFeng.Memcached&version=1.0.0

// Install XiaoFeng.Memcached as a Cake Tool
#tool nuget:?package=XiaoFeng.Memcached&version=1.0.0
```

# XiaoFeng.Memcached

Memcached提供了友好的访问API。

## 基本使用方法

Memcached连接串 

```csharp
memcached://7092734:123456@127.0.0.1:11211/0?ConnectionTimeout=3000&ReadTimeout=3000&SendTimeout=3000&pool=3
```

7092734	    帐号

123456      密码

127.0.0.1	主机

11211		端口

0			0库

ConnectionTimeout	连接超时时长

ReadTimeout		    读取数据超时时长

SendTimeout		    发送数据超时时长

pool			    连接池中连接数量

最小的连接串是：memcached://127.0.0.1

实例化一个memcached对象

```csharp
var memcached = new XiaoFeng.Memcached.MemcachedClient("memcached://7092734@127.0.0.1:11211/0");
```




# 作者介绍

* 网址 : http://www.fayelf.com
* QQ : 7092734
* EMail : jacky@fayelf.com