1xx: Informacyjne

    100 Continue: Serwer otrzyma³ pocz¹tkow¹ czêœæ ¿¹dania i klient powinien kontynuowaæ przesy³anie reszty ¿¹dania.
    101 Switching Protocols: Serwer zgadza siê na zmianê protoko³u na ten okreœlony w nag³ówku Upgrade.

2xx: Sukces

    200 OK: ¯¹danie zakoñczy³o siê sukcesem.
    201 Created: ¯¹danie zakoñczy³o siê sukcesem i zasób zosta³ utworzony.
    202 Accepted: ¯¹danie zosta³o przyjête do realizacji, ale jeszcze nie zosta³o zakoñczone.
    204 No Content: ¯¹danie zakoñczy³o siê sukcesem, ale nie ma ¿adnej treœci do zwrócenia.

3xx: Przekierowania

    301 Moved Permanently: Zasób zosta³ trwale przeniesiony na nowy adres URL.
    302 Found: Zasób znajduje siê tymczasowo pod innym adresem URL.
    304 Not Modified: Zasób nie zosta³ zmodyfikowany od czasu ostatniego ¿¹dania.

4xx: B³êdy klienta

    400 Bad Request: ¯¹danie nie mo¿e byæ obs³u¿one z powodu b³êdu klienta (np. b³êdna sk³adnia).
    401 Unauthorized: ¯¹danie wymaga uwierzytelnienia.
    403 Forbidden: Serwer rozumie ¿¹danie, ale odmawia jego realizacji.
    404 Not Found: Serwer nie móg³ znaleŸæ ¿¹danego zasobu.
    405 Method Not Allowed: Metoda u¿yta w ¿¹daniu jest niedozwolona dla danego zasobu.

5xx: B³êdy serwera

    500 Internal Server Error: Ogólny b³¹d serwera wskazuj¹cy na nieoczekiwany problem.
    501 Not Implemented: Serwer nie obs³uguje funkcjonalnoœci wymaganej do obs³u¿enia ¿¹dania.
    502 Bad Gateway: Serwer dzia³a jako brama lub proxy i otrzyma³ nieprawid³ow¹ odpowiedŸ od upstream serwera.
    503 Service Unavailable: Serwer nie jest dostêpny (np. z powodu przeci¹¿enia lub konserwacji).



### 1xx: Informacyjne
ASP.NET Core domyœlnie nie obs³uguje bezpoœredniego zwracania odpowiedzi z kodami 1xx. Te kody s¹ rzadko u¿ywane w aplikacjach webowych.

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
ASP.NET Core automatycznie zarz¹dza odpowiedziami `304 Not Modified` przy u¿yciu nag³ówków `ETag` i `Last-Modified`. Nie musisz zwykle tego robiæ rêcznie.

### 4xx: B³êdy klienta

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
ASP.NET Core automatycznie zwraca `405 Method Not Allowed` dla metod HTTP, które nie s¹ dozwolone dla danego zasobu, wiêc nie trzeba tego robiæ rêcznie.

### 5xx: B³êdy serwera

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


