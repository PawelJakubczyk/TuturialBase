HTTP to protokoł, ktory
definiuje zasady wymiany
informacji urzadzen w internecie

Okręla w jaki sposób ma być wysłane zapytanie
Co jest wymagane w takim zapytaniu a co nie
Na jakim porcie wysłać to zapytnie
Z drugiej strony wyznacza forme odpowiedzi serwera na zapytanie

HTTP port 80
HTTPS potr 443

Zapytanie(Request):

Czaownik HTTP:
GET,
POST,
PUT,
PATCH,
DELETE

Nagłówki Zapytania

Ciało Zapytania

Odpowiedź(Response):
Kod Statusu
Nagłówki odpowiedzi
Ciało odpowiedzi


**HTTP - a protocol that defines the rules for exchanging information between devices on the internet**

**How to send a request**
------------------------

* **How to send a request**: HTTP uses a request-response model, where a client (e.g. a web browser) sends a request to a server, and the server responds with a response.

![HTTP Request Diagram](.\Images\Request.bmp)

**What is required in a request**
-----------------------------

* **Method**: The HTTP method defines the action to be performed (e.g. GET, POST, PUT, PATCH, DELETE).
* **Headers**: Headers are key-value pairs that provide additional information about the request (e.g. authentication, content type).
* **Body**: The body of the request contains the data being sent (e.g. form data, JSON payload).

**What is not required in a request**
--------------------------------

* **Additional information**: Some headers or parameters may be optional, depending on the specific use case.

**Port numbers**
--------------

* **HTTP**: Typically uses port 80.
* **HTTPS**: Typically uses port 443.

**Request methods**
-----------------

* **GET**: Retrieve data from the server.
* **POST**: Send data to the server to create a new resource.
* **PUT**: Update an existing resource on the server.
* **PATCH**: Update a portion of an existing resource on the server.
* **DELETE**: Delete a resource on the server.

**Response**
------------

* **Status code**: A numerical code indicating the outcome of the request (e.g. 200 OK, 404 Not Found).
* **Headers**: Headers that provide additional information about the response.
* **Body**: The response body contains the actual data being sent back to the client.

Additional notes:

* [**Request Body**] (_Request Body_)
* [**Response Body**] (_Response Body_)
* [**HTTP Method**] (_HTTP Method_)
* [**HTTP Status Code**] (_HTTP Status Code_)
* [**Request Headers**] (_Request Headers_)
* [**Response Headers**] (_Response Headers_)

Note: I used bold text for headings and italic text for notes. I also added some formatting to make the text easier to read. Let me know if you'd like me to make any changes!