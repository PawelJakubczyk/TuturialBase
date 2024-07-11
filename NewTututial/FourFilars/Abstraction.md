| **Abstract Class** | **Interface** |
|-------------------|---------------|
| It contains both declaration and implementation parts. | It contains only the declaration of methods, properties, events, or indexers. Since C# 8, default implementations can also be included in interfaces. |
| Multiple inheritance is not achieved by abstract class. | Multiple inheritance is achieved by interface. |
| It contains constructor. | It does not contain constructor. |
| It can contain static members. | It does not contain static members. |
| It can contain different types of access modifiers like public, private, protected etc. | It only contains public access modifier because everything in the interface is public. |
| The performance of an abstract class is fast. | The performance of interface is slow because it requires time to search actual method in the corresponding class. |
| It is used to implement the core identity of class. | It is used to implement peripheral abilities of class. |
| A class can only use one abstract class. | A class can use multiple interface. |
| If many implementations are of the same kind and use common behavior, then it is superior to use abstract class. | If many implementations only share methods, then it is superior to use Interface. |
| Abstract class can contain methods, fields, constants, etc. | Interface can only contains methods, properties, indexers, events. |
| The keyword “:” can be used for implementing the Abstract class. | The keyword “:” and “,” can be used for implementing the Interface. |
| It can be fully, partially or not implemented. | It should be fully implemented. |
| To declare abstract class, we use abstract keyword. | To declare interface, we use interface keyword. |

