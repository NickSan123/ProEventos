import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NavComponent } from '../nav/nav.component';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  static Pesquisa() {
    throw new Error('Method not implemented.');
  }

  public eventos: any = [];

  isCollapsed = false;
  constructor(private http: HttpClient) { }
  mostrarImagem: boolean = false;
  nomeButton:string = 'Mostrar';
  public filtrados: any = [];

  private _pesquisa: string = '';

  public get pesquisa(): string{
    return this._pesquisa;
  }
  public set pesquisa(value: string){
    this._pesquisa = value;
    this.filtrados = this.pesquisa ? this.filtrarEventos(this.pesquisa) : this.eventos;
  }
  filtrarEventos(pesqu:string): string {
    pesqu = pesqu.toLocaleLowerCase();

    return this.eventos.filter(
      (      evento: { tema: string;local:string; dataEvento:string }) => evento.tema.toLocaleLowerCase().indexOf(pesqu) !== -1 ||
             evento.local.toLocaleLowerCase().indexOf(pesqu) !== -1 ||
             evento.dataEvento.toLocaleLowerCase().indexOf(pesqu) !== -1
      )


  }
  ngOnInit(): void {
    this.getEventos();
  }

  alterarImagem():void{
    this.mostrarImagem = !this.mostrarImagem;
    this.isCollapsed = !this.isCollapsed
    if(this.mostrarImagem)
    this.nomeButton = "Ocultar";
    else
    this.nomeButton = "Mostrar";
  }

  public getEventos(): void{
    this.http.get('https://172.16.0.19:5001/api/Eventos').subscribe(
      Response =>
      {
        this.eventos = Response,
        this.filtrados = this.eventos
      },
      error => console.log(error)
    );
  }

}
