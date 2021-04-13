const DEFAULT_CACHE = "default_cache-v1";

let urls = [
    "/",
    "/css/site.css",
    "/js/site.js"
];
self.addEventListener('install', function (event) {
    event.waitUntil(
        caches.open(DEFAULT_CACHE)
            .then(function (cache) {
                return cache.addAll(urls);
            })
    );
});


self.addEventListener('fetch', (event) => {
    event.respondWith(
        caches.match(event.request).then((resp) => {
            return resp || fetch(event.request).then((response) => response);
        })
    );
});