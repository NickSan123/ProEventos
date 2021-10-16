import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;
  constructor() { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): any{
    this.eventos = [
      {
        Tema: 'Angular',
        Local: 'Mocajuba'
      },
      {
        Tema: 'Chicara para canhoto',
        Local: 'Beco da poeira'
      }
    ]
  }

}
