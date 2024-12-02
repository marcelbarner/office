import { HttpClient } from '@angular/common/http';
import { ChangeDetectionStrategy, Component, inject, OnInit } from '@angular/core';
import { PageHeaderComponent } from '@shared';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
  standalone: true,
  imports: [PageHeaderComponent],
})
export class DashboardComponent implements OnInit {
  ngOnInit(): void {
    this.http.post('api/hello', {firstName: 'Marcel', lastName: 'Barner'}).subscribe((response) => {
      console.log(response);
    });
  }
  private http = inject(HttpClient);
}
