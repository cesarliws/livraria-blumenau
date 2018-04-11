import { Component, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl, FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { LivroComponent } from '../../livro/livro.component';
import { LivroService } from '../../../services/livro.datasource.service';

@Component({
    selector: 'livro-incluir',
    templateUrl: './livro.edit.component.html'
})

export class EditLivroComponent implements OnInit {
    livroForm: FormGroup;
    title: string = "Incluir";
    id: number;
    errorMessage: any;

    constructor(private formBuild: FormBuilder, private activateRoute: ActivatedRoute,
        private livroService: LivroService, private router: Router) {
        
        if (this.activateRoute.snapshot.params["id"]) {
            this.id = this.activateRoute.snapshot.params["id"];
        }

        this.livroForm = this.formBuild.group({
            //id: 0,
            titulo: ['', [Validators.required]],
            autor: ['', [Validators.required]],
            paginas: ['', [Validators.required]],
            editora: ['', [Validators.required]],
            dataPublicacao: ['', [Validators.required]]
        })
    }

    ngOnInit() {
        if (this.id > 0) {
            this.title = "Alterar";
            this.livroService.getLivro(this.id)
                .subscribe(resp => this.livroForm.setValue(resp), 
                    error => this.errorMessage = error);
        }
    }

    save() {
        if (!this.livroForm.valid) {
            return;
        }

        if (this.title == "Incluir") {
            this.livroService.saveLivro(this.livroForm.value)
                .subscribe((data) => {
                    this.router.navigate(['/livro']);
                }, error => this.errorMessage = error)
        }
        else if (this.title == "Alterar") {
            this.livroService.updateLivro(this.livroForm.value)
                .subscribe((data) => {
                    this.router.navigate(['/livro']);
                }, error => this.errorMessage = error) 
        }
    }

    cancel() {
        this.router.navigate(['/livro']);
    }

    get titulo() { return this.livroForm.get('titulo'); }
    get autor() { return this.livroForm.get('autor'); }
    get paginas() { return this.livroForm.get('paginas'); }
    get editora() { return this.livroForm.get('editora'); }
    get dataPublicacao() { return this.livroForm.get('dataPublicacao'); }
}

