**Problem statement and Features**<br/>
You are contacted by a company to build an application that will allow users to create shapes<br/>
based on an input sequence of characters and then manipulate them. As a start, the application<br/>
should support three shapes: circles, squares, and rectangles. More will definitely come later so<br/>
your design should allow easily adding those.<br/>
<br/>
For example, the sequence “c s c r” corresponds to the user wanting to create a circle, a square,<br/>
a circle, and a rectangle – the order matters and you will see why. The first shape will always be<br/>
created with a default size (of your choice but can be changed by the user). The next shape in<br/>
the sequence will be created by doubling the default size. The third shape – by tripling the<br/>
default size, etc. The sequence of shapes entered by the used should be stored in an<br/>
appropriate data structure. The user can manipulate the shapes in different ways. <br/>
<br/>
**In the prototype that you are implementing, the user should be able to:** <br/>
1) Change default size for shapes.<br/>
2) Following shapes should be supported: square, rectangle, circle, pentagon and trapezium. <br/>
3) Shapes can have a color and a border. Borders can have different thickness and pattern
(solid line, dotted line, dashed line, etc.). Both color and shape should have default
values of your choice, but the user should be able to change them for each instance of a
shape. For example, the user might want to have a blue and a red trapezium. <br/>
3) List the shapes that the user has created with all their associate information (ex., type,
size, character).<br/>
3) View the history of the shape creation sequences. In other words, list all sequences of
shapes that she/he has created since the application is running.<br/>
4) Adding a sequence of shapes. This means that the sequence should be added to the
history and the shapes should be created.<br/>
5) Alter the history by deleting or modifying a sequence in the history. The created shapes
need to be updated accordingly.<br/>
6) Compute the area of a sequence of shapes, which is the cumulative area of all existing
shapes.<br/>
7) Filter shapes on specific criteria, such as the area of the shape, color and on thickness.. For example, the user
might want to know what are all shapes whose area is less than or equal to a certain
threshold.<br/>
8) The application should allow the user to undo/redo all operations since the application
has been last started. This means that there is no need to think about making the
undo/redo stack persistent.<br/>
9) The application should be able to save and load data from an XML file.
