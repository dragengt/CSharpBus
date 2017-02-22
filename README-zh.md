#CSharpBus

##何为CSharpBus
CSharpBus 只是一个简单类，用于简化类间关系。

如示例中，类间调用关系可以被简化为：

![exampleRelationship](README/ExampleDraft.jpg)

现在LoginForm 或者 Handler无需获取互相之间的实例，因为View其实只是需要一个能处理其请求的函数即可。所以View会向Bus获得处理函数，然后调用之，即可。

现在，类间关系得到简化，测试单独的类也变得更加容易。
如果你想简化类间关系，就用它吧。

##如何使用
1. 上车先打卡！注册函数：

```CSharp
	//某个类提供了 CanLogin( ) 函数:
	internal void Init()
	{
	    //向bus注册你的函数：
	    CallbackBus.Register("OnLogin", (BoolCallbackWithStrs) CanLogin);
	 }

	public bool CanLogin(string[] strs)
	{
		//...
	}
 ```


2. 在其他类中调用Bus的某个函数：

```CSharp
	//获得函数
	BoolCallbackWithStrs method = CallbackBus.GetBoolCallbackWithStrs(funcName);

	//调用之
	bool checkResult = method(new string[] { userName, userPsw });
```

##NOTE
先注册，才能被使用；
在示例中，使用了InitController去管理类的函数注册。如果你想改进，也可以引入一个XML管理解析，类似于Spring的方法去加载注册的类的函数；