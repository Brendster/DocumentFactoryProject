# Document Factory Project
This project was created in my software design class,

It is a C# program that creates MD documents and html documents from a script written in a .txt file,

Here is a example script that could be used in this project to create documents:


Document:Markdown;index.md# \
Element:Image:img/csharp.png;Alt Text;Title Text# \
Element:Header:1;The Header# \
Element:Header:2;List One# \
Element:List:Ordered;Item 1;Item 2;Item 3# \
Element:Header:2;List Two# \
Element:List:Unordered;Item 1;Item 2;Item 3# \
Element:Header:3;And then a table# \
Element:Table: \
Head$Table Heading 1$Table Heading 2$Table Heading 3; \
Row$Some$Table$Text; \
Row$More$Table$Text; \
Row$Final$Table$Text# \
Run# \
Document:Html;index.html# \
Element:Image:img/csharp.png;Alt Text;Title Text# \
Element:Header:1;The Header# \
Element:Header:2;List One# \
Element:List:Ordered;Item 1;Item 2;Item 3# \
Element:Header:2;List Two# \
Element:List:Unordered;Item 1;Item 2;Item 3# \
Element:Header:3;And then a table# \
Element:Table: \
Head$Table Heading 1$Table Heading 2$Table Heading 3; \
Row$Some$Table$Text; \
Row$More$Table$Text; \
Row$Final$Table$Text# \
Run
