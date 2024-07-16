1xx: Informacyjne

    100 Continue: Serwer otrzyma� pocz�tkow� cz�� ��dania i klient powinien kontynuowa� przesy�anie reszty ��dania.
    101 Switching Protocols: Serwer zgadza si� na zmian� protoko�u na ten okre�lony w nag��wku Upgrade.

2xx: Sukces

    200 OK: ��danie zako�czy�o si� sukcesem.
    201 Created: ��danie zako�czy�o si� sukcesem i zas�b zosta� utworzony.
    202 Accepted: ��danie zosta�o przyj�te do realizacji, ale jeszcze nie zosta�o zako�czone.
    204 No Content: ��danie zako�czy�o si� sukcesem, ale nie ma �adnej tre�ci do zwr�cenia.

3xx: Przekierowania

    301 Moved Permanently: Zas�b zosta� trwale przeniesiony na nowy adres URL.
    302 Found: Zas�b znajduje si� tymczasowo pod innym adresem URL.
    304 Not Modified: Zas�b nie zosta� zmodyfikowany od czasu ostatniego ��dania.

4xx: B��dy klienta

    400 Bad Request: ��danie nie mo�e by� obs�u�one z powodu b��du klienta (np. b��dna sk�adnia).
    401 Unauthorized: ��danie wymaga uwierzytelnienia.
    403 Forbidden: Serwer rozumie ��danie, ale odmawia jego realizacji.
    404 Not Found: Serwer nie m�g� znale�� ��danego zasobu.
    405 Method Not Allowed: Metoda u�yta w ��daniu jest niedozwolona dla danego zasobu.

5xx: B��dy serwera

    500 Internal Server Error: Og�lny b��d serwera wskazuj�cy na nieoczekiwany problem.
    501 Not Implemented: Serwer nie obs�uguje funkcjonalno�ci wymaganej do obs�u�enia ��dania.
    502 Bad Gateway: Serwer dzia�a jako brama lub proxy i otrzyma� nieprawid�ow� odpowied� od upstream serwera.
    503 Service Unavailable: Serwer nie jest dost�pny (np. z powodu przeci��enia lub konserwacji).



### 1xx: Informacyjne
ASP.NET Core domy�lnie nie obs�uguje bezpo�redniego zwracania odpowiedzi z kodami 1xx. Te kody s� rzadko u�ywane w aplikacjach webowych.

### 2xx: Sukces

#### 200 OK
```csharp
[HttpGet("ok")]
public IActionResult GetOk()
{
    return Ok(new { message = "Request succeeded." });
}
```

#### 201 Created
```csharp
[HttpPost("create")]
public IActionResult CreateResource([FromBody] Resource resource)
{
    // Assume the resource is created successfully
    return CreatedAtAction(nameof(GetResource), new { id = resource.Id }, resource);
}
```

#### 202 Accepted
```csharp
[HttpPost("accept")]
public IActionResult AcceptRequest()
{
    // Process the request asynchronously
    return Accepted(new { message = "Request accepted for processing." });
}
```

#### 204 No Content
```csharp
[HttpDelete("delete/{id}")]
public IActionResult DeleteResource(int id)
{
    // Assume the resource is deleted successfully
    return NoContent();
}
```

### 3xx: Przekierowania

#### 301 Moved Permanently
```csharp
[HttpGet("redirect-permanent")]
public IActionResult RedirectPermanentExample()
{
    return RedirectPermanent("https://new-url.com");
}
```

#### 302 Found
```csharp
[HttpGet("redirect")]
public IActionResult RedirectExample()
{
    return Redirect("https://new-url.com");
}
```

#### 304 Not Modified
ASP.NET Core automatycznie zarz�dza odpowiedziami `304 Not Modified` przy u�yciu nag��wk�w `ETag` i `Last-Modified`. Nie musisz zwykle tego robi� r�cznie.

### 4xx: B��dy klienta

#### 400 Bad Request
```csharp
[HttpPost("bad-request")]
public IActionResult BadRequestExample()
{
    return BadRequest(new { error = "Invalid request." });
}
```

#### 401 Unauthorized
```csharp
[HttpGet("unauthorized")]
public IActionResult UnauthorizedExample()
{
    return Unauthorized();
}
```

#### 403 Forbidden
```csharp
[HttpGet("forbidden")]
public IActionResult ForbiddenExample()
{
    return Forbid();
}
```

#### 404 Not Found
```csharp
[HttpGet("not-found")]
public IActionResult NotFoundExample()
{
    return NotFound(new { error = "Resource not found." });
}
```

#### 405 Method Not Allowed
ASP.NET Core automatycznie zwraca `405 Method Not Allowed` dla metod HTTP, kt�re nie s� dozwolone dla danego zasobu, wi�c nie trzeba tego robi� r�cznie.

### 5xx: B��dy serwera

#### 500 Internal Server Error
```csharp
[HttpGet("server-error")]
public IActionResult InternalServerErrorExample()
{
    return StatusCode(StatusCodes.Status500InternalServerError, new { error = "Internal server error." });
}
```

#### 501 Not Implemented
```csharp
[HttpGet("not-implemented")]
public IActionResult NotImplementedExample()
{
    return StatusCode(StatusCodes.Status501NotImplemented, new { error = "Not implemented." });
}
```

#### 502 Bad Gateway
```csharp
[HttpGet("bad-gateway")]
public IActionResult BadGatewayExample()
{
    return StatusCode(StatusCodes.Status502BadGateway, new { error = "Bad gateway." });
}
```

#### 503 Service Unavailable
```csharp
[HttpGet("service-unavailable")]
public IActionResult ServiceUnavailableExample()
{
    return StatusCode(StatusCodes.Status503ServiceUnavailable, new { error = "Service unavailable." });
}
```


