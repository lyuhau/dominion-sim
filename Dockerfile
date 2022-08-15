FROM python:latest
ENV PORT=80

EXPOSE $PORT
COPY Build server
CMD python3 -m http.server --directory server $PORT
