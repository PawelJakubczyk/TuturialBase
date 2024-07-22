

Represents the method that defines a set of criteria and determines whether the specified object meets those criteria.
C#

public delegate bool Predicate<in T>(T obj);

Type Parameters

### T

The type of the object to compare.
This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.
Parameters

### obj T 

The object to compare against the criteria defined within the method represented by this delegate.
Return Value
Boolean

true if obj meets the criteria defined within the method represented by this delegate; otherwise, false.

### Return Value
Boolean

true if obj meets the criteria defined within the method represented by this delegate; otherwise, false.