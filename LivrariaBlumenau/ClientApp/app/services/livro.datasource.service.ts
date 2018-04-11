import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class LivroService {
    apiUrl: string = "";

    constructor(private httpClient: Http, @Inject('BASE_URL') baseUrl: string) {
        this.apiUrl = baseUrl;
    }

    getLivros() {
        return this.httpClient.get(this.apiUrl + 'api/Livro/Index')
            .map((response: Response) => response.json())
            .catch(this.errorHandler);
    }

    getLivro(id: number) {
        return this.httpClient.get(this.apiUrl + "api/Livro/" + id)
            .map((response: Response) => response.json())
            .catch(this.errorHandler)
    }

    saveLivro(livro: any) {
        return this.httpClient.post(this.apiUrl + 'api/Livro/Create', livro)
            .map((response: Response) => response.json())
            .catch(this.errorHandler)
    }

    updateLivro(livro: any) {
        return this.httpClient.put(this.apiUrl + 'api/Livro/Edit', livro)
            .map((response: Response) => response.json())
            .catch(this.errorHandler);
    }

    deleteLivro(id: number) {
        return this.httpClient.delete(this.apiUrl + "api/Livro/Delete/" + id)
            .map((response: Response) => response.json())
            .catch(this.errorHandler);
    }

    errorHandler(error: Response) {
        console.log(error);
        return Observable.throw(error);
    }
}