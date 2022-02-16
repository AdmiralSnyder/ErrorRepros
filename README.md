# ErrorRepros

This Repo i'm gonna use for all error reproductions, hopefully.

## 20220216 - the analyzer that wants me to asynchronously create tool windows doesn't stop whining

![image](https://user-images.githubusercontent.com/16213022/154328869-bc57ff5a-6a2b-4c41-a813-24b8899007ab.png)
![image](https://user-images.githubusercontent.com/16213022/154328909-357870d0-66d2-42f5-8b55-1b18870a1ca1.png)
![image](https://user-images.githubusercontent.com/16213022/154328939-a4e202aa-908f-49e1-872a-9d4b50a03b87.png)


## 200220209 - Error CS0246  The type or namespace name '{0}' could not be found(are you missing a using directive or an assembly reference?)
Projects *ErrorRepro20220209_type_or_namespace_name_0* and *ErrorRepro20220209_Lib*
when putting a `,` at the end of the parameter list in a method that is referenced from another project, the (misleading) errormessage is being shown at the call site with the string format arguments not filled in.
here are screenshots
![Comma in method param list](https://cdn.discordapp.com/attachments/598678594750775301/940948426064011335/unknown.png)
![Error in other file](https://cdn.discordapp.com/attachments/598678594750775301/940948426433101914/unknown.png)
