const DEFAULT_CACHE = "default_cache-v1";

let urls = [
    "/",
    "/css/site.css",
    "/js/site.js"
];
self.addEventListener('install', (event) => {
    event.waitUntil(
        caches.open(DEFAULT_CACHE)
            .then(function (cache) {
                return cache.addAll(urls);
            })
    );
});

self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                // There has been hit in cache so, return the response
                if (response) {
                    return response;
                }
                return event.request;
            })
    );
});