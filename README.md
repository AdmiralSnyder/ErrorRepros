# ErrorRepros

This Repo i'm gonna use for all error reproductions, hopefully.

## 200220209 Error CS0246  The type or namespace name '{0}' could not be found(are you missing a using directive or an assembly reference?)
Projects *ErrorRepro20220209_type_or_namespace_name_0* and *ErrorRepro20220209_Lib*
when putting a `,` at the end of the parameter list in a method that is referenced from another project, the (misleading) errormessage is being shown at the call site with the string format arguments not filled in.
here are screenshots
https://cdn.discordapp.com/attachments/598678594750775301/940948426064011335/unknown.png
https://cdn.discordapp.com/attachments/598678594750775301/940948426433101914/unknown.png
