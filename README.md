# DotNetApplicationStarterPack

An extention method nuget package. To use in your everyday development needs.

This package is at its earliest. Will add more extention methods.

## Installation
`Install-Package DotNetApplicationStarterPack -Version 1.0.0`


## File Pack
### GetFileSizeinKB()
`long fileSize = "c:/users/mytestfile.txt".GetFileSizeinKB(); `

### GenerateRandomFileName()
`string newFileName = "c:/users/mytestfile.txt".GenerateRandomFileName(); `


## Object Pack
### DeepCopy()
` MyClass obj1 = new MyClass();
  MyClass obj2 = obj1.DeepCopy<MyClass>();
`


## Personal Information Pack
### GetAge()
`int age = dateOfBirth.GetAge();`



