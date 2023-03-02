# XiaoFeng.Memcached

![fayelf](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![GitHub top language](https://img.shields.io/github/languages/top/zhuovi/XiaoFeng.Memcached?logo=github)
![GitHub License](https://img.shields.io/github/license/zhuovi/XiaoFeng.Memcached?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/XiaoFeng.Memcached?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/XiaoFeng.Memcached?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/XiaoFeng.Memcached?label=dev%20nuget&logo=nuget)

Nuget：XiaoFeng.Memcached

| QQ群号 | QQ群 | 公众号 |
| :----:| :----: | :----: |
| 748408911  | ![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png) | ![畅聊了个科技](https://user-images.githubusercontent.com/16105174/198059698-adbf29c3-60c2-4c76-b894-21793b40cf34.jpg) |

源码： https://github.com/zhuovi/xiaofeng.Memcached

教程： https://www.yuque.com/fayelf/xiaofeng

Memcached中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Set,Add,Replace,PrePend,Append,Cas,Get,Gets,Gat,Gats,Delete,Touch,Stats,Stats Items,Stats Slabs,Stats Sizes,Flush_All,Increment,Decrement,线程池功能。

## XiaoFeng.Memcached

XiaoFeng.Memcached generator with [XiaoFeng.Memcached](https://github.com/zhuovi/XiaoFeng.Memcached).

## Install

.NET CLI

```
$ dotnet add package XiaoFeng.Memcached --version 1.0.2
```

Package Manager

```
PM> Install-Package XiaoFeng.Memcached --Version 1.0.2
```

PackageReference

```
<PackageReference Include="XiaoFeng.Memcached" Version="1.0.2" />
```

Paket CLI

```
> paket add XiaoFeng.Memcached --version 1.0.2
```

Script & Interactive

```
> #r "nuget: XiaoFeng.Memcached, 1.0.2"
```

Cake

```
// Install XiaoFeng.Memcached as a Cake Addin
#addin nuget:?package=XiaoFeng.Memcached&version=1.0.2

// Install XiaoFeng.Memcached as a Cake Tool
#tool nuget:?package=XiaoFeng.Memcached&version=1.0.2
```

# XiaoFeng.Memcached

XiaoFeng.Memcached提供了友好的访问API。Memcached中间件,支持.NET框架、.NET内核和.NET标准库,一种非常方便操作的客户端工具。实现了Set,Add,Replace,PrePend,Append,Cas,Get,Gets,Gat,Gats,Delete,Touch,Stats,Stats Items,Stats Slabs,Stats Sizes,Flush_All,线程池功能。

## 基本使用方法

Memcached连接串 

```csharp
memcached://memcached:123456@127.0.0.1:11211/?ConnectionTimeout=3000&ReadTimeout=3000&SendTimeout=3000&pool=3
```

memcached   帐号

123456      密码

127.0.0.1	主机

11211		端口

ConnectionTimeout	连接超时时长

ReadTimeout		    读取数据超时时长

SendTimeout		    发送数据超时时长

pool			    连接池中连接数量

最小的连接串是：memcached://127.0.0.1

实例化一个memcached对象

```csharp
var memcached = new XiaoFeng.Memcached.MemcachedClient("memcached://memcached:123456@127.0.0.1:11211");
```

#使用方法

```csharp
//实例化
var memcached = new XiaoFeng.Memcached.MemcachedClient("memcached://memcached:123456@127.0.0.1:11211");
//最大压缩比
memcached.CompressLength = 1024;
//协议
memcached.MemcachedProtocol = MemcachedProtocol.Text;
//Hash算法
memcached.Transform = new XiaoFeng.Memcached.Transform.FNV1_64();

//给key设置一个值
var set = memcached.Set("abc", "abcda");
//如果key不存在的话，就添加
var add1 = memcached.Add("abc", "abcde");
//如果key不存在的话，就添加
var add2 = memcached.Add("a1", "abcde");
//如果key不存在的话，就添加 异步
var add3 = await memcached.AddAsync("a2", "abcde");
//用来替换已知key的value
var replace1 = memcached.Replace("a3", "abc3");
//用来替换已知key的value
var replace2 = memcached.Replace("a2", "abc3");
//表示将提供的值附加到现有key的value之后，是一个附加操作
var append1 = memcached.Append("a3", "a4f");
//表示将提供的值附加到现有key的value之后，是一个附加操作
var append2 = memcached.Append("a2", "a2f");
//将此数据添加到现有数据之前的现有键中
var prepend1 = memcached.Prepend("a3", "a3d");
//将此数据添加到现有数据之前的现有键中
var prepend2 = memcached.Prepend("a2", "a3d");
//一个原子操作，只有当casunique匹配的时候，才会设置对应的值
var cas = memcached.Cas("a1", "aaa", 113);
//获取key的value值，若key不存在，返回空。
var get1 = memcached.Get("a1");
//获取key的value值，若key不存在，返回空。
var get2 = memcached.Get("a1", "a2");
//用于获取key的带有CAS令牌值的value值，若key不存在，返回空。
var gets1 = memcached.Gets("a1");
//用于获取key的带有CAS令牌值的value值，若key不存在，返回空。
var gets2 = memcached.Gets("a1", "a2");
//获取key的value值，若key不存在，返回空。更新缓存时间
var gat = memcached.Gat(5*24 * 60, "a1");
//获取key的value值，若key不存在，返回空。更新缓存时间
var gat1 = memcached.Gat(6*24 * 60, "a1","a2");
//用于获取key的带有CAS令牌值的value值，若key不存在，返回空。支持多个key 更新缓存时间
var gats = memcached.Gats(5 * 24 * 60, "a1");
//用于获取key的带有CAS令牌值的value值，若key不存在，返回空。支持多个key 更新缓存时间
var gats1 = memcached.Gats(6 * 24 * 60, "a1", "a2");
//删除已存在的 key(键)
var delete = memcached.Delete("a10");
//给key设置一个值
var set3 = memcached.Set("a10", 100);
//递增
var incr1 = memcached.Increment("a10", 10);
//递减
var decr1 = memcached.Decrement("a10", 10);
//修改key过期时间
var touch = memcached.Touch("a10", 24 * 60);
//统计信息
var stats = memcached.Stats();
//显示各个 slab 中 item 的数目和存储时长(最后一次访问距离现在的秒数)
var items = memcached.StatsItems();
//显示各个slab的信息，包括chunk的大小、数目、使用情况等
var slabs = memcached.StatsSlabs();
//显示所有item的大小和个数
var sizes = memcached.StatsSizes();
//用于清理缓存中的所有 key=>value(键=>值) 对
var flushall = memcached.FulshAll();
```



# 作者介绍

* 网址 : http://www.fayelf.com
* QQ : 7092734
* EMail : jacky@fayelf.com