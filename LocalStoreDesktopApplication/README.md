**Problem statement and Features**<br/>
You are contacted by a local store to build a desktop application in C# that will allow employees to look <br/>
up the availability of a certain products and to restock. All products have a unique ID and a description.<br/>
Products can be physical (ex. pen) or electronic (ex. e-book). For physical products, the store will have 0<br/>
or more items of a certain product available at a specific moment. Electronic products are unlimited.<br/>
<br/>
**The set of features that the software must support are the following:**<br/>
</br>
**- Search:** An employee can search for a product in the store database. Employees will enter a<br/>
sequence of characters (which can enter either be a (partial) code and/or keywords) and the<br/>
search should be performed on all possible fields (i.e., the employee should not be asked<br/>
whether she/he wants to search by code or by keywords, this must be handled implicitly). If<br/>
the sequence of characters contains one or more spaces, it would need to be split into<br/>
tokens and the employee should be asked whether this is an AND search (all tokens must be<br/>
present in each product) or and OR search (at least one of the tokens must be present in<br/>
each product). The result will be the list of products that match the search. For each product<br/>
that matches the search all available information about the product and the current items<br/>
associated with that product at the moment in the store must be displayed. If the user 4<br/>
enters an empty sequence of characters, i.e., she/he simply hits enter or space(s), then the<br/>
result should be all products in the store.<br/>
</br>
**- Save search:** If an employee selects this functionality, the last search that was performed
will be saved to a file in a subdirectory of the project called “searches”. The file name should
indicate the date and time that the search was performed in the following format: <yyyy>-
<mm>-<dd>-<hh>h<mm>m<ss>s.txt. For example, if the search was performed at
8:34:30pm on February 4, 2021 the filename would be “2021-02-04-20h34m30s.txt”
The first line of the file should contain the sequences of characters that the employee used
for the search and whether it was an AND or OR search if applicable. The rest of the file, i.e.,
starting from line 2, must contain the result of the search as it was shown to the employee.
</br>
**- Restock:** If an employee selects this functionality, all physical products with less than N<br/>
items will be restocked, where N is provided by the employee. First, the list of products that<br/>
match the search will be shown, i.e., all products where the number of items is less than N.<br/>
Then, the employee will be asked whether she/he would like to restock for all of them: If the<br/>
response is positive, then for each product that matches the search all available information<br/>
about the product and the number of current items associated with that product at the<br/>
moment in the store must be displayed and the employee would be asked how many<br/>
additional items need to be purchased. After that, a confirmation must be shown that the<br/>
purchase is successful, and the updated product information must be shown. If the response<br/>
is negative, the user should be given the option to change N or to return to the main menu<br/>
