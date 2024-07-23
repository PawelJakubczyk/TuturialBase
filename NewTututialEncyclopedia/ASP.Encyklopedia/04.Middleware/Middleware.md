Middleware, to specjalny kawałek kodu, który jest
wykonywany podczas przetwarzania zapytania na serwerze.

Cała logika, która jest wykonywana po stronie serwera,
składa się z wielu middleware.

Każdy middleware określa, czy przekazywać żądanie do
następnego middleware czy nie.

Może też wykonywać swoją pracę przed następnym
middleware i po nim.

musimy go najpierw zarejestrować w metodzie
ConfigureServices, a następnie użyć w konkretnym
miejscu metody Configure.

Miejsce w którym użyjemy middleware jest istotnie,
i ponieważ w takiej kolejności będą one przetwarzane.

Jeżeli chcielibyśmy utworzyć customowy middleware,
wystarczy, że do projektu dodamy klasę,
implementującą interface IMiddleware, a następnie
odpowiednio ją zarejestrujemy i użyjemy.