
FROM python:latest

COPY Build server

CMD python3 -m http.server --directory server 8080
