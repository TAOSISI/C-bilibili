 事件模型的五个组成部分
事件的拥有者（event source，对象）
事件成员（event，成员）事件本身，不会主动发生
事件的响应者（event subscriber，对象）
事件处理器（event handler，对象）——本质上是一个回调问题
事件订阅——把事件处理器与事件关联在一起，本质上是一种以委托类型为基础的“约定”
EventExample 一个简单的事件例子
EventExample2 事件的拥有者与事件的响应者是不同的对象
EventExample3 事件的拥有者与事件的响应者是同一个对象
EventExample4 事件的拥有者是事件的响应者的字段成员（最常见）
FormApp 一个事件可以挂接多个事件处理器。
WinFormExample 一个事件处理器可以被多个事件挂接


