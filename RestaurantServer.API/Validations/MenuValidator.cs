using FluentValidation;
using RestaurantServer.API.Dtos;

namespace RestaurantServer.API.Validations
{
    public class MenuValidator:AbstractValidator<MenuDto>
    {
        public MenuValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz.")
                             .MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz.")
                                       .MaximumLength(100).WithMessage("Açıklama en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün Görseli boş bırakılamaz");

        }
    }
}
